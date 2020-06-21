import React, { Component } from 'react';

export class FiverrItem extends Component {
    render() {
        return (
            <div>
                <p>ID: {this.props.fiverrItem.id} | Descrição: {this.props.fiverrItem.nvcDescription}</p>
            </div>
        )
    }
}

export default FiverrItem;