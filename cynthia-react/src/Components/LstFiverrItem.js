import React, { Component } from 'react';
import FiverrItem from './FiverrItem'
import TopNavBar from './TopNavBar'

class LstFiverrItem extends Component {

    render() {
        return this.props.arrFiverrItem.map((fiverrItem) =>
            [
            <FiverrItem key={fiverrItem.id} fiverrItem={fiverrItem} />
            ,<TopNavBar/>
            ])
    }
}

export default LstFiverrItem;
